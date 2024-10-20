﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetFireStore.Domain.Common
{
    public class BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
        public Guid? UserID { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
