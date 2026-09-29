namespace Akutmottagningen.Questions
{
    internal class InputHander
    {
        public enum InputData
        {
            String,
            Int,
            Float,
            DateTime,
            Bool,
        }


        public T GetUserInput<T>(InputData dataType, Func<T, bool> validator, string errorMessage)
        {
            string input = "";
            string inputLC;
            T parsedGeneric = default;//have to assign
            bool success;

            while (true)
            {
                input = Console.ReadLine();
                success = false;

                switch (dataType)
                {
                    case InputData.String:
                        
                        success = !string.IsNullOrEmpty(input);

                        if (success)
                            parsedGeneric = (T)(object)input;
                        break;
                    case InputData.Int:
                        success = int.TryParse(input, out int inputInt);
                        if (success)
                            parsedGeneric = (T)(object)inputInt;
                        break;
                    case InputData.Float:
                        success = float.TryParse(input, out float inputFloat);
                        if (success)
                            parsedGeneric = (T)(object)inputFloat;
                        break;
                    case InputData.DateTime:

                        if(input is string)
                        {
                            success = DateTime.TryParse(input, out DateTime date);

                            if (success)
                                parsedGeneric = (T)(object)date;
                        }                        
                        break;
                }

                if (success && validator(parsedGeneric))
                    return parsedGeneric;

                Console.WriteLine(errorMessage);
            }
        }
    }
}
