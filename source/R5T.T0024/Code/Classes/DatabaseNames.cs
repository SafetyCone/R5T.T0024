using System;


namespace R5T.T0024
{
    public class DatabaseNames : IDatabaseNames
    {
        #region Static

        public static DatabaseNames Instance { get; } = new DatabaseNames();

        #endregion
    }
}
