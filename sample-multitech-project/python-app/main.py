from utils import validate_user

def get_user(user_id: int):
    user = {"id": user_id, "name": "Dummy Python User"}

    if not validate_user(user):
        raise Exception("Invalid user")

    return user

if __name__ == "__main__":
    print(get_user(1))
