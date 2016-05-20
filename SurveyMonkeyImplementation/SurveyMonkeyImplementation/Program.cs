﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;

namespace SurveyMonkeyImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            GetSurveys();


        }


        static string getHeader()
        {
            var AuthHeader = "bearer z2FJSWRZHEvQ1tX4owdlxkwBFJyV7.Wi4ldMSC4wTMX2cGXVnZJ4qvpsvvgGrI2geMfvNwtbOrO6DrIfmjsDT5z.u1no-RE2uh57CqEHZgNdJvpl1ycuy5xen5bVOUcsPw0w6V8KRklcH9TgtB.KmXck-GU9e5TXNAx0oWcjNSV1yRUqnAGA5NjgGc0nr5TsxzViO2jUIU01K5dzo4IK8SewJFBmdPMSW-b9YZ6JnkU=";

            return AuthHeader;
        }
        static WebRequest GetSurveys()
        {

            var AuthHeader = "bearer z2FJSWRZHEvQ1tX4owdlxkwBFJyV7.Wi4ldMSC4wTMX2cGXVnZJ4qvpsvvgGrI2geMfvNwtbOrO6DrIfmjsDT5z.u1no-RE2uh57CqEHZgNdJvpl1ycuy5xen5bVOUcsPw0w6V8KRklcH9TgtB.KmXck-GU9e5TXNAx0oWcjNSV1yRUqnAGA5NjgGc0nr5TsxzViO2jUIU01K5dzo4IK8SewJFBmdPMSW-b9YZ6JnkU=";

            var request = WebRequest.Create("https://api.surveymonkey.net/v3/surveys?api_key=vw39bqgh87p9cws4w2pjba3g");
            request.Headers["Authorization"] = getHeader();
            var response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);
            reader.Close();
            response.Close();

            return request;
        }
    }
}
