import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class main_test {
    @Test
    void addNumbersWithPositiveIntegers() {
        assertEquals(15, Main.addNumbers(5, 10));
    }
    @Test
    void addNumbersWithNegativeIntegers() {
        assertEquals(-15, Main.addNumbers(-5, -10));
    }
    @Test
    void addNumbersWithZeroAndPositiveInteger() {
        assertEquals(10, Main.addNumbers(0, 10));
    }
    @Test
    void addNumbersWithZeroAndNegativeInteger() {
        assertEquals(-10, Main.addNumbers(0, -10));
    }
    @Test
    void addNumbersWithTwoZeros() {
        assertEquals(0, Main.addNumbers(0, 0));
    }
    @Test
    void addNumbersWithLargePositiveIntegers() {
        assertEquals(3000000, Main.addNumbers(1000000, 2000000));
    }
    @Test
    void addNumbersWithLargeNegativeIntegers() {
        assertEquals(-3000000, Main.addNumbers(-1000000, -2000000));
    }
    @Test
    void addNumbersWithPositiveAndNegativeInteger() {
        assertEquals(-5, Main.addNumbers(5, -10));
    }
    @Test
    void addNumbersWithMaxIntegerValues() {
        assertEquals(-2147483648, Main.addNumbers(Integer.MAX_VALUE, 1));
    }
    @Test
    void addNumbersWithMinIntegerValues() {
        assertEquals(2147483647, Main.addNumbers(Integer.MIN_VALUE, -1));
    }
}