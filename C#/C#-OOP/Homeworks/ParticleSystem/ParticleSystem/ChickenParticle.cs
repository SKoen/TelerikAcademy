using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ChickenParticle : ChaoticParticle
    {
        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random random)
            : base(position, speed, random)
        {
            this.LayEgg = true;
            this.StayPosition = false;
        }

        public int TickCounter { get; protected set; }

        public int TickStay { get; protected set; }

        public bool StayPosition { get; protected set; }

        public bool LayEgg { get; protected set; }

        protected void NewMove()
        {
            var currentRowSpeed = this.Speed.Row;
            var currentColSpeed = this.Speed.Col;

            this.Accelerate(new MatrixCoords(currentRowSpeed + this.randomGenerator.Next(-1, 2), currentColSpeed + this.randomGenerator.Next(-1, 2)));

            this.Move();
        }

        public override IEnumerable<Particle> Update()
        {
            var result = new List<Particle>();

            if (this.StayPosition == false)
            {
                this.Accelerate(new MatrixCoords(-this.Speed.Row, -this.Speed.Col));

                if (this.randomGenerator.Next(0, 100) < 20)
                {
                    this.StayPosition = true;
                    this.TickStay = this.randomGenerator.Next(0, 15);

                    if (this.LayEgg == true)
                    {
                        var eggSpeed = new MatrixCoords(this.randomGenerator.Next(-1, 2), this.randomGenerator.Next(-1, 2));
                        result.Add(new ChickenParticle(this.Position, eggSpeed, this.randomGenerator));
                        this.LayEgg = false;
                    }
                }
                else
                {
                    NewMove();
                }
            }
            else
            {
                this.TickCounter++;

                if (this.TickCounter == this.TicksToStay)
                {
                    this.TickCounter = 0;
                    this.StayOnPosition = false;
                    this.LayEgg = true;
                    NewMove();
                }
            }

            return result;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'C' } };
        }
    }
}