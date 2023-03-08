using System;


namespace R5T.Z0034
{
    public class StackOverflowLinks : IStackOverflowLinks
    {
        #region Infrastructure

        public static IStackOverflowLinks Instance { get; } = new StackOverflowLinks();


        private StackOverflowLinks()
        {
        }

        #endregion
    }
}
