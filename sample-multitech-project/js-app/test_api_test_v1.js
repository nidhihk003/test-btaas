describe('api_test', () => {
  test('fetchUserWithValidId', () => {
    expect(fetchUser(1)).toBe({'id': 1, 'name': 'John Doe', 'email': 'john.doe@example.com'});
  });
  test('fetchUserWithNonExistentId', () => {
    expect(fetchUser(9999)).toBe(Error: Request failed with status code 404);
  });
  test('fetchUserWithInvalidIdType', () => {
    expect(fetchUser('invalid_id')).toBe(Error: Request failed with status code 400);
  });
  test('fetchUserWithValidIdButInvalidData', () => {
    expect(fetchUser(2)).toBe(Error: Invalid);
  });
  test('fetchUserWithValidIdAndIncompleteData', () => {
    expect(fetchUser(3)).toBe(Error: Invalid);
  });
  test('fetchUserWithNullId', () => {
    expect(fetchUser(null)).toBe(Error: Request failed with status code 400);
  });
  test('fetchUserWithUndefinedId', () => {
    expect(fetchUser(undefined)).toBe(Error: Request failed with status code 400);
  });
  test('fetchUserWithNegativeId', () => {
    expect(fetchUser(-1)).toBe(Error: Request failed with status code 400);
  });
  test('fetchUserWithFloatId', () => {
    expect(fetchUser(1.5)).toBe(Error: Request failed with status code 400);
  });
  test('fetchUserWithSpecialCharacterId', () => {
    expect(fetchUser('!@#')).toBe(Error: Request failed with status code 400);
  });
});