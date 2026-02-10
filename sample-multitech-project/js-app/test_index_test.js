describe('index_test', () => {
  test('addPositiveNumbers', () => {
    expect(addNumbers(5, 10)).toBe(15);
  });
  test('addNegativeNumbers', () => {
    expect(addNumbers(-5, -10)).toBe(-15);
  });
  test('addMixedSignNumbers', () => {
    expect(addNumbers(5, -10)).toBe(-5);
  });
  test('addZeroAndPositiveNumber', () => {
    expect(addNumbers(0, 10)).toBe(10);
  });
  test('addZeroAndNegativeNumber', () => {
    expect(addNumbers(0, -10)).toBe(-10);
  });
  test('addTwoZeros', () => {
    expect(addNumbers(0, 0)).toBe(0);
  });
  test('addLargeNumbers', () => {
    expect(addNumbers(1000000, 2000000)).toBe(3000000);
  });
  test('addDecimalNumbers', () => {
    expect(addNumbers(1.5, 2.5)).toBe(4);
  });
  test('addNumberAndString', () => {
    expect(addNumbers(5, '10')).toBe(510);
  });
  test('addNumberAndNull', () => {
    expect(addNumbers(5, null)).toBe(5);
  });
});