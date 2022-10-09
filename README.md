![license](https://img.shields.io/github/license/prahladyeri/SimplePMS.svg)
![last-commit](https://img.shields.io/github/last-commit/prahladyeri/SimplePMS.svg)
[![patreon](https://img.shields.io/badge/Patreon-brown.svg?logo=patreon)](https://www.patreon.com/prahladyeri)
[![paypal](https://img.shields.io/badge/PayPal-blue.svg?logo=paypal)](https://paypal.me/prahladyeri)
[![follow](https://img.shields.io/twitter/follow/prahladyeri.svg?style=social)](https://twitter.com/prahladyeri)

# Simple PMS

Simple PMS is a Project Management application for individual freelancers, hobbyists, students, etc.

![main screen](screenshots/main.png)

# Technology

Runs on any Windows OS where .NET Framework 4.0 (or above) is installed, built with C# (WinForms) technology.

# Features

- Create and track projects, milestones and tasks.
- Time tracking with system tray icon.
- Create and track ad-hoc notes.
- Create and track hierarchical notes (mind-maps).

# Usage

The SimplePMS paradigm divides a project's work details into projects, milestones and tasks. Projects have a start and end date as well as status (Pending/WIP/Complete). It also has a category (Work/Study/Other). This model is simple enough to implement most typical errands such as an online course taken or working on a side project such as this!

A project can have one or more milestones and each milestone can have one or more tasks. Typical milestones and tasks for this one (Development of SimplePMS app) might include:

1. Analysis
	- Study the technical feasibility.
2. Development
	- Create a github repository.
	- Create Visual C# Solution.
	- Coding GUI and components.
3. Testing
	- Perform unit testing using nunit.
4. Bug Fixing
	- Track Github issue tracker.

# Third party components

- Images/Icons by [Yusuke Kamiyamane](https://p.yusukekamiyamane.com/) - Creative Commons 3 License.
- SQLite .NET Driver by [System.net.sqlite.org](https://system.data.sqlite.org/) - Microsoft Public License, MSPL.

# Installation and running the solution

Solution can be opened in any recent Visual Studio IDE versions including the Express editions. Just download and add a reference to [SQLite .NET DLL](https://system.data.sqlite.org/) and you should be able to build.

Right now, the project is in the analysis and requirements gathering stage. I'll keep updating the repo as and when things progress. If you have any thoughts on schema, features, technology, etc., feel free to shoot them through the discussion pane!
