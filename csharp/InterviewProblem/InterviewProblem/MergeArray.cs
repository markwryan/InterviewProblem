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
	        var a1Len = array1.Length;
	        var a2Len = array2.Length;
	        var totalLen = a1Len + a2Len;
	        var array3 = new char[totalLen];
	        
	        //a1 = [a,b,c] 
	        //a2 = [1,2,3]
	        //array3 = a1[0] + a2[0] + a1[1] + a2[1] + a1[2] + a2[2]
	        
	        //a3[0] = 'a'
	        //a3[1] = '1'
	        
	        for (var i = 0; i < totalLen; i++)
	        {
		        array3[i] = array1[i];
		        
		        array3[i + 1] = array2[i];
	        }
	        

        }
    }
}
