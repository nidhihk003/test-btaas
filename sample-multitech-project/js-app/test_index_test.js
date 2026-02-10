describe('index_test', () => {
  test('addPositiveNumbers', () => {
    expect(addNumbers(5, 10)).toBe(15);
  });
  test('addNegativeNumbers', () => {
    expect(addNumbers(-3, -7)).toBe(-10);
  });
  test('addPositiveAndNegativeNumbers', () => {
    expect(addNumbers(10, -5)).toBe(5);
  });
  test('addZeroAndNumber', () => {
    expect(addNumbers(0, 7)).toBe(7);
  });
  test('addNumberAndZero', () => {
    expect(addNumbers(7, 0)).toBe(7);
  });
  test('addZeros', () => {
    expect(addNumbers(0, 0)).toBe(0);
  });
  test('addLargeNumbers', () => {
    expect(addNumbers(1000000, 2000000)).toBe(3000000);
  });
  test('addNumberAndString', () => {
    expect(addNumbers(5, '10')).toBe(510);
  });
  test('addStrings', () => {
    expect(addNumbers('5', '10')).toBe(510);
  });
  test('addWithNullInput', () => {
    expect(addNumbers(5, null)).toBe(5);
  });
});