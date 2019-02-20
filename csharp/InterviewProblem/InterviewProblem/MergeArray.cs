using System;

namespace InterviewProblem
{
    public static class MergeArray
    {
	    /*
	     * Given two arrays of variable sizes, return a new array taking one element from the head of each array in turn
	     * until each element has been selected once and added to the new array.
	     *
	     * ['1','2','3','4'] and ['a','b','c'] => ['1','a','2','b','3','c','4']
	     */
        public static char[] Merge(char[] array1, char[] array2)
        {
	        char[] array3 = new char[8];
	        for (int i = 0; i < array1.Length;i = i+2)
	        {
		        
		        if (i > 0)
		        {
			        array3[i] = array1[i - 1];
		        }
		        else
		        {
			        array3[i] = array1[i];
		        }
	        }

	        for (int j = 1; j < array2.Length; j = j + 2)
	        {
		        array3[j] = array2[j-1];
	        }
	        return array3;        
        }
    }
}
