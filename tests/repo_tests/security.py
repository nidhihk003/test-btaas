import httpx
from fastapi import HTTPException, status
from repo_router.py import TokenRequest

class GitHubClient:
    BASE_URL = "https://api.github.com"

    def __init__(self, token: str):
        # If token received is encrypted, then decrypt it using:
        # decryptor = TokenEncryptor()
        # token = decryptor.decrypt(token)

        self.headers = {
            "Authorization": f"token {token}",
            "Accept": "application/vnd.github+json"
        }

    async def validate_token(self):
        async with httpx.AsyncClient(timeout=10) as client:
            response = await client.get(f"{self.BASE_URL}/user", headers=self.headers)

        if response.status_code != 200:
            raise HTTPException(
                status_code=status.HTTP_401_UNAUTHORIZED,
                detail="Invalid or expired GitHub token"
            )

        return response.json()

    async def validate_repo_access(self, owner: str, repo: str):
        async with httpx.AsyncClient(timeout=10) as client:
            response = await client.get(
                f"{self.BASE_URL}/repos/{owner}/{repo}",
                headers=self.headers
            )

        if response.status_code != 200:
            raise HTTPException(
                status_code=status.HTTP_403_FORBIDDEN,
                detail="Token does not have access to this repository"
            )

        return response.json()

    async def list_repos(self):
        async with httpx.AsyncClient(timeout=10) as client:
            response = await client.get(
                f"{self.BASE_URL}/user/repos",
                headers=self.headers
            )

        if response.status_code != 200:
            raise HTTPException(
                status_code=500,
                detail="Failed to fetch repositories"
            )

        return response.json()
