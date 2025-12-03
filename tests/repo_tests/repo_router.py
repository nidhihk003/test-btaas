from fastapi import APIRouter, HTTPException
from pydantic import BaseModel
from security import GitHubClient

router = APIRouter(prefix="/repo", tags=["Repo Mode"])


class TokenRequest(BaseModel):
    provider: str                  # github | gitlab (future proof)
    encrypted_token: str                     # raw GitHub token
    repo_owner: str                # GitHub username or organization

def get_decrypted_token(encrypted_token: str) -> str:
    encryptor = TokenEncryptor()
    try:
        return encryptor.decrypt(encrypted_token)
    except Exception:
        raise HTTPException(status_code=400, detail="Invalid encrypted token")


@router.post("/validate-token")
async def validate_token(data: TokenRequest):
    """
    Decrypts GitHub token and validates it.
    Returns authenticated user info.
    """
    if data.provider.lower() != "github":
        raise HTTPException(status_code=400, detail="Only GitHub is supported currently")

    token = get_decrypted_token(data.encrypted_token)
    client = GitHubClient(token=token)

    try:
        user_data = await client.validate_token()
    except HTTPException as e:
        raise e

    return {
        "status": "valid",
        "user": user_data.get("login"),
        "repo_owner": data.repo_owner,
        "provider": data.provider
    }


# @router.post("/encrypt-token")
# async def encrypt_token(data: TokenRequest):
#     """
#     Encrypts the provided GitHub token using TokenEncryptor.
#     """
#     encryptor = TokenEncryptor()
#     encrypted_token = encryptor.encrypt(data.token)

#     return {
#         "encrypted_token": encrypted_token,
#         "repo_owner": data.repo_owner,
#         "provider": data.provider
    # }
