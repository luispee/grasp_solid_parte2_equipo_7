//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Net.NetworkInformation;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        //public para que ConsolePrinter pueda acceder
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        public double TotalCost { get 
            {
                double totalCost = 0;
                foreach (Step step in this.steps)
                {
                    totalCost += step.GetProductionCost(step);
                }
                return totalCost;
            } 
        }

    }
}