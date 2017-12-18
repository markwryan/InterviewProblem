package com.markwryan;

public class MergeArray {

    public static char[] Merge(char[] array1, char[] array2) {
        if(array1 == null) {
            return array2;
        }
        if(array2 == null) {
            return array1;
        }

        int totalElements = array1.length + array2.length;
        boolean elementsRemaining = totalElements > 0;
        char[] mergedElements = new char[totalElements];
        int elementIndex = 0;
        int mergedIndex = 0;

        while(elementsRemaining) {
            if(elementIndex <  array1.length) {
                mergedElements[mergedIndex] = array1[elementIndex];
                mergedIndex++;
            }

            if(elementIndex < array2.length) {
                mergedElements[mergedIndex] = array2[elementIndex];
                mergedIndex++;
            }

            elementsRemaining = (elementIndex < array1.length || elementIndex < array2.length);
            elementIndex++;
        }
        return mergedElements;
    }
}
