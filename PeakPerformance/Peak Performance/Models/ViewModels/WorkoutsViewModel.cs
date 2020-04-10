﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Peak_Performance.DAL;
using Microsoft.AspNet.Identity;

namespace Peak_Performance.Models.ViewModels
{
    public class WorkoutsViewModel
    {
/*        private readonly PeakPerformanceContext db = new PeakPerformanceContext();
        public WorkoutsViewModel(Coach coach, int team, DateTime date)
        {
            Date = date;
            Team = db.Teams.FirstOrDefault(t => t.ID == team);
            Coach = coach;
            NewWorkout = new Workout();
            NewWorkout.Team = Team;
            NewWorkout.TeamID = Team.ID;
            NewWorkout.WorkoutDate = Date;
            Complexes = db.Complexes.Where(c => c.WorkoutID == NewWorkout.WorkoutsId).ToList();
            foreach (var c in Complexes)
            {
                foreach (var i in db.ComplexItems.Where(i => i.ComplexId == c.ComplexesId))
                {
                    ComplexItems.Append(i);
                }
            }
        }

        public int addComplex()
        {
            Complex temp = new Complex();
            temp.WorkoutID = NewWorkout.WorkoutsId;
            Complexes.Append(temp);

            return temp.ComplexesId;
        }

        public void addComplexItem(int ComplexId, Exercis exercise, int? reps, int? sets, double? weight, double? distance, double? speed, TimeSpan? time)
        {
            ComplexItem item = new ComplexItem();
            item.ComplexId = ComplexId;
            item.ExerciseID = exercise.ExercisesId;
            item.ComplexReps = reps;
            item.ComplexSets = sets;
            item.LiftWeight = weight;
            item.RunDistance = distance;
            item.RunSpeed = speed;
            item.RunTime = time;
            ComplexItems.Append(item);
            return;
        }

        public void submitWorkout()
        {
            db.Workouts.Add(NewWorkout);

            foreach (var c in Complexes)
            {
                db.Complexes.Add(c);
            }

            foreach (var i in ComplexItems)
            {
                db.ComplexItems.Add(i);
            }

            db.SaveChanges();

            return;
        }*/
        public DateTime date { get; set; }

        public string team {get; set;}
        
        public ComplexesViewModel complexes { get; set; }
    }

    public class ComplexesViewModel
    {
        public List<ComplexViewModel> complex { get; set; }
    }

    public class ComplexViewModel
    { 
        public List<ExerciseViewModel> exercise { get; set; }
    
    }

    public class ExerciseViewModel
    {
        string name { get; set; }
        int reps { get; set; }
        int sets { get; set; }
        double weight { get; set; }
        TimeSpan time { get; set; }
        double speed { get; set; }
        double distance { get; set; }
    }
}