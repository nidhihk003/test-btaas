describe('app.component_test', () => {
  test('addWithPositiveNumbers', () => {
    expect(appComponent.add(5, 3)).toBe(8);
  });
  test('addWithNegativeNumbers', () => {
    expect(appComponent.add(-5, -3)).toBe(-8);
  });
  test('addWithPositiveAndNegativeNumbers', () => {
    expect(appComponent.add(5, -3)).toBe(2);
  });
  test('addWithZero', () => {
    expect(appComponent.add(0, 0)).toBe(0);
  });
  test('addWithPositiveNumberAndZero', () => {
    expect(appComponent.add(5, 0)).toBe(5);
  });
  test('addWithNegativeNumberAndZero', () => {
    expect(appComponent.add(-5, 0)).toBe(-5);
  });
  test('addWithLargeNumbers', () => {
    expect(appComponent.add(1000000, 2000000)).toBe(3000000);
  });
  test('addWithMinimumSafeInteger', () => {
    expect(appComponent.add(Number.MIN_SAFE_INTEGER, 1)).toBe(-9007199254740990);
  });
  test('addWithMaximumSafeInteger', () => {
    expect(appComponent.add(Number.MAX_SAFE_INTEGER, -1)).toBe(9007199254740990);
  });
  test('addWithInvalidInputs', () => {
    expect(appComponent.add('5', 3)).toBe(nan);
  });
});