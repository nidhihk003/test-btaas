from utils import add_numbers

def handler():
    return add_numbers(5, 10)

if __name__ == "__main__":
    print("Result:", handler())
