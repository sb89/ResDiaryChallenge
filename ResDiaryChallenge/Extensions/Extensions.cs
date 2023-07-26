namespace ResDiaryChallenge.Extensions;

public static class Extensions
{
    /// <summary>
    /// Splits the array into N (numberOfGroups) equally sized sub-arrays. The last sub-array will contain the remainder
    /// if an equal split is not possible.
    /// </summary>
    /// <param name="sourceArray">The array to be split</param>
    /// <param name="numberOfGroups">The number of sub-arrays to be returned.</param>
    /// <returns>An array of sub-arrays</returns>
    /// <exception cref="ArgumentException">Thrown if source array is null or numberOfGroups is less that or equal to 0.</exception>
    public static T[][] GroupElements<T>(this T[]? sourceArray, int numberOfGroups)
    {
        if (sourceArray == null)
        {
            throw new ArgumentException("Source cannot be null");
        }

        if (numberOfGroups <= 0)
        {
            throw new ArgumentException("GroupSize must be greater than 0");
        }

        int groupSize = sourceArray.Length / numberOfGroups;
        int remainder = sourceArray.Length % numberOfGroups;
        int nextStartIndex = 0;

        T[][] result = new T[numberOfGroups][];
        for (int i = 0; i < numberOfGroups; i++)
        {
            int subGroupSize = groupSize;
            if (i < remainder)
            {
                // Distribute the remainder across the subgroups
                subGroupSize += 1;
            }

            result[i] = new T[subGroupSize];

            for (int j = 0; j < subGroupSize; j++)
            {
                result[i][j] = sourceArray[nextStartIndex + j];
            }

            nextStartIndex += subGroupSize;
        }
        
        return result;
    }
}