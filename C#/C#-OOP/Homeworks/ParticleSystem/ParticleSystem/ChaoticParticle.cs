using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        protected Random randomGenerator = new Random();

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random rand):
            base(position, speed)
        {
        }
        public void ChangeSpeed(ChaoticParticle change)
        {
            change.Speed += new MatrixCoords(randomGenerator.Next(0,3),randomGenerator.Next(0,3));
        }
    }
}
