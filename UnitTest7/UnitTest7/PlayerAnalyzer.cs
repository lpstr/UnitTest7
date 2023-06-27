﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest7
{
    public class PlayerAnalyzer

    {

        public double CalculateScore(List<Player> players)

        { 

            double score = 0;

            foreach (var player in players)
            {
                if (player.Skills == null)
                {
                    throw new ArgumentNullException(nameof(player.Skills));
                }

                double skillsAverage = player.Skills.Sum() / (double)player.Skills.Count;

                double contribution = player.Age * player.Experience * skillsAverage;



                if (player.Age < 18)

                {

                    contribution *= 0.5;

                }



                if (player.Experience > 10)

                {

                    contribution *= 1.2;

                }



                score += contribution;

            }

            return score;

        }
    }
}
