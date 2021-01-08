using System;

namespace Bowyer.EntityFrameworkCore.Interfaces
{
    public interface IArchiveable
    {
        DateTime ArchivedDate { get; set; }

        int? ArchivedByUserId { get; set; }
    }
}