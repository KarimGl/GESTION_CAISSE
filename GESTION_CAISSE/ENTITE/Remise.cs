﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_CAISSE.ENTITE
{
    class Remise
    {
        public Remise()
        {
            grilles = new List<GrilleRabais>();
        }

        public Remise(long id)
        {
            this.id = id;
            grilles = new List<GrilleRabais>();
        }

        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private String reference;
        public String Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        private String baseRemise;
        public String BaseRemise
        {
            get { return baseRemise; }
            set { baseRemise = value; }
        }

        private bool permanent;
        public bool Permanent
        {
            get { return permanent; }
            set { permanent = value; }
        }

        private List<GrilleRabais> grilles;
        internal List<GrilleRabais> Grilles
        {
            get { return grilles; }
            set { grilles = value; }
        }

        private bool update;
        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        private bool select;
        public bool Select
        {
            get { return select; }
            set { select = value; }
        }

        private bool new_;
        public bool New_
        {
            get { return new_; }
            set { new_ = value; }
        }
    }
}
