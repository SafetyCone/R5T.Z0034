using System;

using R5T.R0008.Extensions;
using R5T.R0008.T000;
using R5T.T0131;


namespace R5T.Z0034
{
    [ValuesMarker]
    public partial interface IStackOverflowLinks : IValuesMarker
    {
        /// <summary>
        /// <see href="https://stackoverflow.com/questions/42221895/how-to-get-an-instance-of-iserviceprovider-in-net-core"/>
        /// </summary>
        public Link HowToGetAnISerivceProviderInstance => "https://stackoverflow.com/questions/42221895/how-to-get-an-instance-of-iserviceprovider-in-net-core".ToLink();
    }
}
