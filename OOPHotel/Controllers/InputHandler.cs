namespace Akutmottagningen.Questions
{
    internal class InputHander
    {
        public enum InputData
        {
            String,
            Int,
            Float,
        }


        public T GetUserInput<T>(InputData dataType, Func<T, bool> validator)
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
                        if (int.TryParse(input, out int i))//break if it's an int, not acceptable
                            break;
                        else if (float.TryParse(input, out float f))//break if float, not acceptable
                            break;

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
                }

                if (success && validator(parsedGeneric))
                    return parsedGeneric;

                Console.WriteLine("Det gick ej att tolka ditt svar, var god försök igen.");
            }
        }
    }
}
