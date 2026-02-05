def validate_user(user: dict) -> bool:
    return "id" in user and "name" in user
