from db import get_user_from_db
from utils import validate_user

def get_user(id:int):
    user = get_user_from_db(id)
    if not validate_user(user):
        raise Exception("invalid")
    return user
print(get_user(1))
