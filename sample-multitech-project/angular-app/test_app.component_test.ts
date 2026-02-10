describe('app.component_test', () => {
  test('addTwoPositiveNumbers', () => {
    expect(new AppComponent().add(3, 5)).toBe(8);
  });
  test('addPositiveAndNegativeNumber', () => {
    expect(new AppComponent().add(7, -2)).toBe(5);
  });
  test('addTwoNegativeNumbers', () => {
    expect(new AppComponent().add(-4, -6)).toBe(-10);
  });
  test('addZeroAndPositiveNumber', () => {
    expect(new AppComponent().add(0, 9)).toBe(9);
  });
  test('addZeroAndNegativeNumber', () => {
    expect(new AppComponent().add(0, -3)).toBe(-3);
  });
  test('addTwoZeros', () => {
    expect(new AppComponent().add(0, 0)).toBe(0);
  });
  test('addLargeNumbers', () => {
    expect(new AppComponent().add(1000000, 2000000)).toBe(3000000);
  });
  test('addNumberAndInfinity', () => {
    expect(new AppComponent().add(5, Infinity)).toBe(inf);
  });
  test('addNumberAndNaN', () => {
    expect(new AppComponent().add(4, NaN)).toBe(nan);
  });
  test('addNumberAndNull', () => {
    expect(new AppComponent().add(4, null)).toBe(4);
  });
});