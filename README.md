![license](https://img.shields.io/github/license/prahladyeri/SimplePMS.svg)
![last-commit](https://img.shields.io/github/last-commit/prahladyeri/SimplePMS.svg)
[![patreon](https://img.shields.io/badge/Patreon-brown.svg?logo=patreon)](https://www.patreon.com/prahladyeri)
[![paypal](https://img.shields.io/badge/PayPal-blue.svg?logo=paypal)](https://paypal.me/prahladyeri)
[![follow](https://img.shields.io/twitter/follow/prahladyeri.svg?style=social)](https://twitter.com/prahladyeri)

# Simple PMS

Simple PMS is a Project Management application for individual freelancers, hobbyists, students, etc.

![main screen](screenshots/main.png)

# Compatibility

- Windows: XP and above (.NET Framework 3.5+ is the only dependency).
- Linux: Theoretically possible to run with [Wine compatibility layer](https://www.winehq.org/) and Mono Runtime.

# Features

- Create and track projects, milestones and tasks.
- Time tracking with system tray icon.
- Create and track ad-hoc notes with reminders.
- Create and track hierarchical notes (mind-maps).

# Usage

The SimplePMS paradigm divides a project's work details into projects, milestones and tasks. Projects have a start and end date as well as status (Pending/WIP/Complete). They also have a category (Work/Study/Other). This model is simple enough to implement most typical errands such as an online course taken or working on a side project such as this.

A project can have one or more milestones and each milestone can have one or more tasks. Typical milestones and tasks for this project (Development of SimplePMS app) might include:

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


# Installation

Installation is very easy, just grab the latest build [from here](https://github.com/prahladyeri/simplepms/releases/latest), extract the ZIP archive to a folder on your computer and start simplepms.exe. When the app runs for first time, it creates the database file (`pms.db`) if it doesn't exist already.

# Build

Solution can be opened, compiled and debugged using any recent Visual Studio IDE version (2010 and later). Just download the .NET and Interop DLLs for your target framework version from [system.data.sqlite.org](https://system.data.sqlite.org/), add them to project reference and build the solution.

# Support

Report any bugs found on the [issue tracker](https://github.com/prahladyeri/SimplePMS/issues). For major customization or professional support, you can [hire me](https://prahladyeri.github.io/about) for freelance development.