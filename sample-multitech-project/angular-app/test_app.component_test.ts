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
  test('addPositiveNumberAndZero', () => {
    expect(new AppComponent().add(9, 0)).toBe(9);
  });
  test('addZeroAndNegativeNumber', () => {
    expect(new AppComponent().add(0, -3)).toBe(-3);
  });
  test('addTwoZeros', () => {
    expect(new AppComponent().add(0, 0)).toBe(0);
  });
  test('addWithFirstParameterAsMaxNumber', () => {
    expect(new AppComponent().add(Number.MAX_VALUE, 1)).toBe(1.7976931348623157e+308);
  });
  test('addWithSecondParameterAsMaxNumber', () => {
    expect(new AppComponent().add(1, Number.MAX_VALUE)).toBe(1.7976931348623157e+308);
  });
  test('addWithFirstParameterAsMinNumber', () => {
    expect(new AppComponent().add(Number.MIN_VALUE, 1)).toBe(1);
  });
  test('addWithSecondParameterAsMinNumber', () => {
    expect(new AppComponent().add(1, Number.MIN_VALUE)).toBe(1);
  });
});