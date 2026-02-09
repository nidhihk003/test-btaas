describe('service_test', () => {
  test('getUserWithValidId', () => {
    expect(getUser(1)).toBe({'id': 1, 'name': 'Dummy TS User'});
  });
  test('getUserWithZeroId', () => {
    expect(getUser(0)).toBe({'id': 0, 'name': 'Dummy TS User'});
  });
  test('getUserWithNegativeId', () => {
    expect(getUser(-1)).toBe({'id': -1, 'name': 'Dummy TS User'});
  });
  test('getUserWithLargeId', () => {
    expect(getUser(9999999999)).toBe({'id': 9999999999, 'name': 'Dummy TS User'});
  });
  test('getUserWithNonNumericId', () => {
    expect(getUser('abc')).toBe({'id': nan, 'name': 'Dummy TS User'});
  });
  test('getUserWithNullId', () => {
    expect(getUser(null)).toBe({'id': 0, 'name': 'Dummy TS User'});
  });
  test('getUserWithUndefinedId', () => {
    expect(getUser(undefined)).toBe({'id': 0, 'name': 'Dummy TS User'});
  });
  test('getUserWithBooleanTrueId', () => {
    expect(getUser(true)).toBe({'id': 1, 'name': 'Dummy TS User'});
  });
  test('getUserWithBooleanFalseId', () => {
    expect(getUser(false)).toBe({'id': 0, 'name': 'Dummy TS User'});
  });
  test('getUserWithObjectId', () => {
    expect(getUser({})).toBe({'id': nan, 'name': 'Dummy TS User'});
  });
});