namespace QLib;

public class BubbleSort
{
    public int[] Sort(int[] values)
    {
        if (values == null)
            throw new ArgumentNullException(nameof(values));

        if (values.Length <= 1)
            return values;

        for (var startIndex = 0; startIndex < values.Length; startIndex++)
        {
            var currentMinSameIndex = startIndex;
            var currentMinSameValue = values[startIndex];
            for (var rightIndex = currentMinSameIndex + 1; rightIndex < values.Length; rightIndex++)
            {
                if (values[rightIndex] < currentMinSameValue)
                {
                    currentMinSameIndex = rightIndex;
                    currentMinSameValue = values[rightIndex];
                }
            }

            if (startIndex != currentMinSameIndex)
            {
                values[currentMinSameIndex] = values[startIndex];
                values[startIndex] = currentMinSameValue;
            }
        }

        return values;
    }
}