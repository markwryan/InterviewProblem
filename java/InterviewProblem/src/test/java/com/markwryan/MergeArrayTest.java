package com.markwryan;

import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;

public class MergeArrayTest {

    /**
     * Merge two items with an equal number of elements
     */
    @Test
    public void mergeEqualItemsTest() {
        char[] charArray1 = {'a', 'b', 'c'};
        char[] charArray2 = {'1', '2', '3'};
        final char[] expectedResult = {'a', '1', 'b', '2', 'c', '3'};
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge equal number of items, reversing the order of the input arrays
     */
    @Test
    public void mergeEqualItemsReverseOrderTest() {
        char[] charArray1 = {'1', '2', '3'};
        char[] charArray2 = {'a', 'b', 'c'};
        final char[] expectedResult = {'1', 'a', '2', 'b', '3', 'c'};
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items with differing number of elements
     */
    @Test
    public void mergeUnequalItemsTest() {
        char[] charArray1 = {'a', 'b'};
        char[] charArray2 = {'1', '2', '3','4'};
        final char[] expectedResult = {'a','1','b','2','3','4'};
        char[] result =  MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items, each with a larger, equal amount of elements
     */
    @Test
    public void mergeLargeEqualItemsTest() {
        char[] charArray1 = { 'f', '5', 'c', 'q', '9', '-', 't', '1' };
        char[] charArray2 = { '4', '2', '3', '/', 'e', '8', 'v', 'x' };
        final char[] expectedResult = {'f', '4', '5', '2', 'c', '3', 'q', '/', '9', 'e', '-', '8', 't', 'v', '1', 'x'};
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items, each with a larger, unequal amount of elements
     */
    @Test
    public void mergeLargeUnequalItemsTest() {
        char[] charArray1 = { 'f', '5', 'c', 'q', '9', '-', 't', '1' };
        char[] charArray2 = { '4', '2', '3' };
        final char[] expectedResult = {'f', '4', '5', '2', 'c', '3', 'q', '9', '-', 't', '1'};
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items, where one is null
     */
    @Test
    public void mergeItemsOneNullTest() {
        char[] charArray1 = null;
        char[] charArray2 = { '4', '2', '3' };
        final char[] expectedResult = { '4', '2', '3' };
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items where both are null
     */
    @Test
    public void mergeItemsBothNullTest() {
        char[] charArray1 = null;
        char[] charArray2 = null;
        final char[] expectedResult = null;
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items where one is a empty array
     */
    @Test
    public void mergeItemsOneEmpty() {
        char[] charArray1 = {};
        char[] charArray2 = { '4', '2', '3' };
        final char[] expectedResult = { '4', '2', '3' };
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }

    /**
     * Merge two items where both are empty arrays
     */
    @Test
    public void mergeItemsBothEmpty() {
        char[] charArray1 = {};
        char[] charArray2 = {};
        final char[] expectedResult = {};
        char[] result = MergeArray.Merge(charArray1, charArray2);

        assertArrayEquals(expectedResult, result);
    }
}
