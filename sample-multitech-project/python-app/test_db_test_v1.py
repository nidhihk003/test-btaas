def test_valid_user_id():
    assert get_user_from_db(1) == {'id': 1, 'name': 'db-user'}

def test_minimum_valid_user_id():
    assert get_user_from_db(0) == {'id': 0, 'name': 'db-user'}

def test_negative_user_id():
    assert get_user_from_db(-1) == {'id': -1, 'name': 'db-user'}

def test_large_user_id():
    assert get_user_from_db(1000000) == {'id': 1000000, 'name': 'db-user'}

def test_maximum_int_user_id():
    assert get_user_from_db(2147483647) == {'id': 2147483647, 'name': 'db-user'}

def test_minimum_int_user_id():
    assert get_user_from_db(-2147483648) == {'id': -2147483648, 'name': 'db-user'}

def test_boundary_positive_user_id():
    assert get_user_from_db(2147483646) == {'id': 2147483646, 'name': 'db-user'}

def test_boundary_negative_user_id():
    assert get_user_from_db(-2147483647) == {'id': -2147483647, 'name': 'db-user'}

def test_zero_user_id():
    assert get_user_from_db(0) == {'id': 0, 'name': 'db-user'}

def test_one_user_id():
    assert get_user_from_db(1) == {'id': 1, 'name': 'db-user'}
