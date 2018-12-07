package com.markwryan;

import sun.reflect.generics.reflectiveObjects.NotImplementedException;

import java.util.Arrays;
import java.util.List;
import java.util.ArrayList;

class MergeArray {

    /*
     * Given two arrays of variable sizes, return a new array taking one element from
     * the head of each array in turn until each element has been selected once and
     * added to the new array.
     *
     * ['1','2','3','4'] and ['a','b','c'] => ['1','a','2','b','3','c','4']
     */
    static char[] Merge(char[] array1, char[] array2) {
        if (array1 == null && array2 == null) return null;
        if (array1 == null) array1 = new char[0];
        if (array2 == null) array2 = new char[0];


        List<Character> list1 = new ArrayList<Character>();
        for (int i = 0; i < array1.length; i++)
            list1.add(array1[i]);

        List<Character> list2 = new ArrayList<Character>();
        for (int i = 0; i < array2.length; i++)
            list2.add(array2[i]);
        List<Character> zipped = new ArrayList<Character>();

        int shorterLength = list1.size() < list2.size() ? list1.size() : list2.size();

        for (int i = 0; i < shorterLength; i++){
            zipped.add(list1.get(i));
            zipped.add(list2.get(i));
        }

        List<Character> longer = shorterLength == list1.size() ? list1 : list2;
        for (int i = shorterLength; i < longer.size(); i++){
            zipped.add(longer.get(i));
        }

        char[] zippedAr = new char[zipped.size()];
        for (int i = 0; i< zippedAr.length; i++){
            zippedAr[i] = zipped.get(i);
        }
        return zippedAr;
    }
}
