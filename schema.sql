drop table if exists projects;
drop table if exists milestones;
drop table if exists tasks;
drop table if exists timesheet;
drop table if exists notes;
drop table if exists mindmaps;
drop table if exists mcq;


create table projects (
	id integer primary key,
	status text, -- (Pending/WIP/Complete)
	name text,
	type text, -- (Work/Study/Other)
	tags text, -- (Tech/PHP/Python)
	start_date datetime,
	end_date datetime,
	notes text
);

create table milestones (
	id integer primary key,
	project_id int,
	status text,
	foreign key (project_id) references projects(id)
);

create table tasks (
	id integer primary key,
	milestone_id int,
	status text,
	category text, -- (study/work/writing/etc.)
	tags text,
	notes text,
	foreign key (milestone_id) references milestones(id)
);

create table timesheet (
	id integer primary key,
	task_id int,
	fdate datetime,
	tdate datetime,
	notes text,
	foreign key (task_id) references tasks(id)
);

create table mindmaps (
	id integer primary key,
	parent_id int, -- parent item's id or null in case of top level
	status text, -- Pending/WIP/Complete
	name text, -- topic name
	tags text,
	links text,
	notes int,
	foreign key (parent_id) references mindmaps (id)
);

create table notes (
	id integer primary key,
	status text, -- Pending/WIP/Complete
	topic text,
	notes text
);
	
-- mcq @todo