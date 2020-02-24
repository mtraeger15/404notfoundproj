CREATE TABLE [dbo].[MuscleGroups]
(
    [ID] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(200),
	CONSTRAINT [PK_dbo.MuscleGroups] PRIMARY KEY CLUSTERED ([ID] ASC)
)

CREATE TABLE [dbo].[Exercises]
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR(128),
	[URL] NVARCHAR(MAX),
	CONSTRAINT [PK_dbo.Exercises] PRIMARY KEY CLUSTERED ([ID] ASC)
)

CREATE TABLE [dbo].[ExcerciseMuscleGroups]
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [MuscleGroupID] INT NOT NULL,
	[ExerciseID] INT NOT NULL,
    
	CONSTRAINT [FK_dbo.ExerciseMuscleGroups_dbo.MuscleGroups_MuscleGroupsID] FOREIGN KEY ([MuscleGroupID]) REFERENCES [dbo].[MuscleGroups] ([ID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.ExerciseMuscleGroups_dbo.Exercises_ExerciseID] FOREIGN KEY ([ExerciseID]) REFERENCES [dbo].[Exercises] ([ID]) ON DELETE CASCADE,
	CONSTRAINT [PK_dbo.ExerciseMuscleGroups] PRIMARY KEY CLUSTERED ([ID] ASC)
)

CREATE TABLE [dbo].[Workouts]
(
    [ID] INT NOT NULL IDENTITY(1,1),
	[WorkoutDate] DATE NOT NULL,
	[TeamID] INT NOT NULL,

	CONSTRAINT [FK_dbo.Workouts_dbo.Teams_TeamID] FOREIGN KEY ([TeamID]) REFERENCES [dbo].[Teams] ([ID]) ON DELETE CASCADE,
	CONSTRAINT [PK_dbo.Workouts] PRIMARY KEY CLUSTERED ([ID] ASC)
)

CREATE TABLE [dbo].[Complexes]
(
    [ID] INT NOT NULL IDENTITY(1,1),
	[WorkoutID] INT,

	CONSTRAINT [FK_dbo.Complexes_dbo.Workouts_WorkoutID] FOREIGN KEY ([WorkoutID]) REFERENCES [dbo].[Workouts] ([ID]) ON DELETE CASCADE,
	CONSTRAINT [PK_dbo.Complexes] PRIMARY KEY CLUSTERED ([ID] ASC)
)

CREATE TABLE [dbo].[ComplexItems]
(
    [ID] INT NOT NULL IDENTITY(1,1),
	[ComplexReps] INT,
	[ComplexSets] INT,
	[LiftWeight] FLOAT,
	[RunSpeed] FLOAT,
	[RunTime] TIME,
	[RunDistance] FLOAT,
	[ExerciseID] INT NOT NULL,
    [ComplexId] INT NOT NULL,
    
	CONSTRAINT [FK_dbo.ComplexItems_dbo.Exercises_ExerciseID] FOREIGN KEY ([ExerciseID]) REFERENCES [dbo].[Exercises] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.ComplexItems_dbo.Complexes_ComplexID] FOREIGN KEY ([ComplexId)] REFERENCES [dbo].[Complexes] ([ID]) ON DELETE CASCADE,
	CONSTRAINT [PK_dbo.ComplexItems] PRIMARY KEY CLUSTERED ([ID] ASC)
)