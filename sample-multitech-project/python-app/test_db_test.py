def test_get_user_from_db_with_valid_id():
    assert get_user_from_db(1) == {'id': 1, 'name': 'db-user'}

def test_get_user_from_db_with_zero_id():
    assert get_user_from_db(0) == {'id': 0, 'name': 'db-user'}

def test_get_user_from_db_with_negative_id():
    assert get_user_from_db(-1) == {'id': -1, 'name': 'db-user'}

def test_get_user_from_db_with_large_positive_id():
    assert get_user_from_db(999999999) == {'id': 999999999, 'name': 'db-user'}

def test_get_user_from_db_with_large_negative_id():
    assert get_user_from_db(-999999999) == {'id': -999999999, 'name': 'db-user'}

def test_get_user_from_db_with_non_integer_id_string():
    assert get_user_from_db('string_id') == TypeError

def test_get_user_from_db_with_non_integer_id_none():
    assert get_user_from_db(None) == TypeError

def test_get_user_from_db_with_float_id():
    assert get_user_from_db(1.5) == TypeError

def test_get_user_from_db_with_boolean_true_id():
    assert get_user_from_db(True) == {'id': 1, 'name': 'db-user'}

def test_get_user_from_db_with_boolean_false_id():
    assert get_user_from_db(False) == {'id': 0, 'name': 'db-user'}
