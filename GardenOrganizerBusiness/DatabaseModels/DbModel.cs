using System;

namespace Business.DatabaseModels
{
    public abstract class DbModel
    {
        public bool IsDeleted { get; set; } = false;

        public DateTime LastUpdated { get; set; }
    }
}
