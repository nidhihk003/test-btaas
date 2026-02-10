describe('index_test', () => {
  test('addTwoPositiveNumbers', () => {
    expect(addNumbers(5, 10)).toBe(15);
  });
  test('addTwoNegativeNumbers', () => {
    expect(addNumbers(-5, -10)).toBe(-15);
  });
  test('addPositiveAndNegativeNumber', () => {
    expect(addNumbers(5, -10)).toBe(-5);
  });
  test('addZeroAndPositiveNumber', () => {
    expect(addNumbers(0, 10)).toBe(10);
  });
  test('addZeroAndNegativeNumber', () => {
    expect(addNumbers(0, -10)).toBe(-10);
  });
  test('addZeroAndZero', () => {
    expect(addNumbers(0, 0)).toBe(0);
  });
  test('addLargeNumbers', () => {
    expect(addNumbers(1000000, 2000000)).toBe(3000000);
  });
  test('addNumberAndString', () => {
    expect(addNumbers(5, '10')).toBe(510);
  });
  test('addStringAndNumber', () => {
    expect(addNumbers('5', 10)).toBe(510);
  });
  test('addStringAndString', () => {
    expect(addNumbers('5', '10')).toBe(510);
  });
});