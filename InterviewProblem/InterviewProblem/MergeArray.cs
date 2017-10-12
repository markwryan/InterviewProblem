namespace InterviewProblem
{
    public class MergeArray
    {
        public static char[] Merge(char[] array1, char[] array2)
        {
            var totalElements = array1.Length + array2.Length;
            var elementsRemain = totalElements > 0;
            var mergedElements = new char[totalElements];
            var elementIndex = 0;
            var mergedIndex = 0;
            while (elementsRemain)
            {
                if (elementIndex < array1.Length)
                {
                    mergedElements[mergedIndex] = array1[elementIndex];
                    mergedIndex++;
                }

                if (elementIndex < array2.Length)
                {
                    mergedElements[mergedIndex] = array2[elementIndex];
                    mergedIndex++;
                }

                if (elementIndex >= array1.Length && elementIndex >= array2.Length)
                {
                    elementsRemain = false;
                }
                elementIndex++;
            }
            return mergedElements;
        }
    }
}
