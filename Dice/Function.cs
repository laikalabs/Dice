[assembly: Amazon.Lambda.Core.LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Dice
{
    using System;

    using Alexa.NET;
    using Alexa.NET.Request;
    using Alexa.NET.Response;
    using Amazon.Lambda.Core;

    public class Function
    {
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            SkillResponse skillResponse = ResponseBuilder.Tell($"El resultado es un {GenerateARandomNumber()}");
            skillResponse.Response.ShouldEndSession = false;
            return skillResponse;
        }
        
        private int GenerateARandomNumber()
        {
            return new Random().Next(1, 7);
        }
    }
}
