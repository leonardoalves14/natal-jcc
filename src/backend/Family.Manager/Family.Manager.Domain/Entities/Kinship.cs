﻿using System;

namespace Family.Manager.Domain.Entities
{
    public class Kinship : Entity<Guid>
    {
        private Kinship() { }

        public Kinship(
            string description,
            string personName,
            Guid familyId)
        {
            Id = Guid.NewGuid();
            Description = description;
            PersonName = personName;
            FamilyId = familyId;
        }

        public string Description { get; set; }
        public string PersonName { get; set; }
        public Guid FamilyId { get; private set; }
        public Family Family { get; private set; }
    }
}
