README
# GymWebApp

## Table of Contents
## Expectations of the Project
## My Approach
## Architecture
  * ERD
  * Balsamiq
  * Use Case
  * Trello
## Risk Assessment
## Testing
## Known Issues
## Reflection

## Expectation of the project
The main expectation of this project was to provide a CRUD application with supporting documentation, testing and utilisation of all revelant tools explored in the past few weeks. I had to ensure my application allowed a user to create, read(view), update and delete.
I have included the following 
1.A trello board
2.A relation database, consisting of two tables
3.Documentation of the design phase, architecture and risk assessment matrix.
4.A C# based functional application allowing for CRUD functions

### My Approach.
I produced a GymWebApp that allowed for the following
1. A Gymnast to be created that contained the following values:
- Name
- Age
- AgeSection
- Nationality
- PictureURL
- Apparatus
- CreatedAt
- ID
2.A Judge who would be assigned to a gymnast for each appartus which contained the following values:
- ID
- Name
- AgeSection
- Apparatus
- GymnastID


### Architecture
### Database Structure
Please see below an ERD showing the structure a relationships between data entities.
[ERD .pdf](https://github.com/CP-118378361/QATut1/files/6435488/ERD.pdf)

The ERD demonstrated a 1 to many relationship between gymnasts and judges. A gymnast can be assigned to many judges but for judge to exist it must be assigned to a gymnast.

![Screenshot (13)](https://user-images.githubusercontent.com/46994774/117582303-4a032f00-b0f9-11eb-862e-b04ee7db608d.png)

### Front-End Design - Website GUI
Please see attached below my balsamiq wireframes[GUIS.pdf](https://github.com/CP-118378361/QATut1/files/6434856/GUIS.pdf)

### Use Case
[Use case diagram.pdf](https://github.com/CP-118378361/QATut1/files/6434830/Use.case.diagram.pdf)

![Screenshot (14)](https://user-images.githubusercontent.com/46994774/117582322-61dab300-b0f9-11eb-8e82-c5a7cafc78f5.png)

The Use case demonstrates how the CRUD application works and how Judge interacts with a Gymnasts profile.

### Project Tracking
https://trello.com/b/J5Voo0E4/design-sprint
![Screenshot (7)](https://user-images.githubusercontent.com/46994774/117307383-6fcdd100-ae78-11eb-880a-2795ef140106.png)

My Trello board contains the following
1. Pre-Sprint prep- This involves outline the necessary steps taken before the project began.
2. Epics - these relate to the large amounts of work/tasks which can be broken down.
3. Product backlog items- are items which can be implement to further improve the application, they are single sources of work which can be completed.
4. Tasks- involve work that needs to be done in this project that is the 4 main elements of a crud application.
5. User Stories- explains the end goal of people who interact with the application through an informal explanation of the software features.


## Risk Assessemnt
[Risk Assessment.xlsx](https://github.com/CP-118378361/QATut1/files/6434945/Risk.Assessment.xlsx)
![Screenshot (16)](https://user-images.githubusercontent.com/46994774/117582374-9d757d00-b0f9-11eb-9782-1250a029266e.png)

## Testing
-

## Known Issues
-Testing isn't complete
-Age Section and Apparatus show up as 0 until they're edited
-Add judges doesn't save 

## Reflection 
There is defintely improvements I would like to make
- Ensure that a different judge has to be assigned to each appartus for a gymnast
- Testing is something I need to learn to do properly and hopefully become confident in doing it.
- Become better at troubleshooting code on own which is defintely something I improved throughout the project time
- I'm also happy with how I adapt to using C# as I had never used it up until a few weeks ago.


