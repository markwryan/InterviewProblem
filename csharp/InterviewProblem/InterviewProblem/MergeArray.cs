using System;
using System.Runtime.Remoting.Messaging;

namespace InterviewProblem
{
    public static class MergeArray
    {
	    /*
	     * Given two arrays of variable sizes, return a new array taking one element
	     * from the head of each array in turn until each element has been selected
	     * once and added to the new array.
	     *
	     * ['1','2','3','4'] and ['a','b','c'] => ['1','a','2','b','3','c','4']
	     */
        public static char[] Merge(char[] array1, char[] array2)
        {
	        char[] newArray = new char[array1.Length + array2.Length];
	        int j = 0;

	        if (array2.Length > array1.Length)
	        {
		        
	        }
	        for (int i = 0; i < newArray.Length - 1; i++)
	        {
		        newArray[j] = array1[i];
		        newArray[j + 1] = array2[i];
		        j = j + 2;
	        }
		        
		        
	        return newArray;
        }
    }
}
