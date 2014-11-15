using System;
using System.Linq;
using Kanc.MVP.Tests.nHibernate.Core;
using NHibernate.Linq;
using NUnit.Framework;
using Utils.Extensions;

namespace Kanc.MVP.Tests.nHibernate
{
    [TestFixture]
    public class nHibernateTests : NHibernateFixtureBase
    {
        [Test]
        public void t1_simple_add_user()
        {
            var user1 = new User { Name = "a", Surname = "b" };
            Session.Save(user1);

            // Assertion
            Session.Flush();
            Session.Clear();

            var fromDb = Session.Get<User>(user1.Id);

            Assert.AreNotSame(user1, fromDb);
            Assert.AreEqual(user1.Name, fromDb.Name);
        }

        [Test]
        public void t2_assign_unsaved_user_to_project()
        {
            var userA = new User { Name = "a", Surname = "aa" };
            var userB = new User { Name = "b", Surname = "bb" };
            var project = new Project() {Name = "proj1", User = userA};

            
            Session.Save(userA);
            Session.Save(userB);
            Session.Save(project);

            Session.Flush();
            Session.Clear();
            var fromDb = Session.Get<Project>(project.Id);

            Assert.AreNotSame(project, fromDb);
            Assert.AreEqual(project.Name, fromDb.Name);

            Assert.AreNotSame(userA, fromDb.User);
            Assert.AreEqual(userA.Name, fromDb.User.Name);
        }

        [Test]
        public void t3_assign_many_task_to_project()
        {
            var userA = new User { Name = "a", Surname = "aa" };
            var userB = new User { Name = "b", Surname = "bb" };
            var project = new Project() { Name = "proj1", User = userA };

            Session.Save(userA);
            Session.Save(userB);
            Session.Save(project);

            var task1 = new Task() { Name = "task1", Project = project };
            var task2 = new Task() { Name = "task2", Project = project };

            project.Tasks.Add(task1);
            project.Tasks.Add(task2);
            
            Session.Save(task1);
            Session.Save(task2);
            Session.Save(project);

            Session.Flush();
            Session.Clear();
            var fromDb = Session.Get<Project>(project.Id);

            Assert.AreNotSame(task1, fromDb.Tasks[0]);
            Assert.AreEqual(task1.Name, fromDb.Tasks[0].Name);

            Assert.AreNotSame(task2, fromDb.Tasks[1]);
            Assert.AreEqual(task2.Name, fromDb.Tasks[1].Name);
        }

        private void PrepareData()
        {
            var userA = new User { Name = "a", Surname = "aa" };
            var userB = new User { Name = "b", Surname = "bb" };
            Session.Save(userA);
            Session.Save(userB);

            var project1 = new Project() { Name = "proj1", User = userA };
            var project2 = new Project() { Name = "proj2", User = userB };
            Session.Save(project1);
            Session.Save(project2);

            var task1 = new Task() { Name = "task1", Project = project1 };
            var task2 = new Task() { Name = "task2", Project = project1 };
            //
            var task3 = new Task() { Name = "task3", Project = project2 };
            var task4 = new Task() { Name = "task4", Project = project2 };
            
            Session.Save(task1);
            Session.Save(task2);
            Session.Save(task3);
            Session.Save(task4);
            
            //
            Session.Flush();
            Session.Clear();
        }

        [Test]
        public void t4_get_project_query()
        {
            PrepareData();
            //

            var fromDb = Session.Query<Project>()
                .FetchMany(x => x.Tasks)
                .Where(x => x.User.Name == "a")
                .OrderBy(x => x.Id)
                .Single();

            Assert.That(fromDb, Is.Not.Null);
            Assert.That(fromDb.Tasks.Count(), Is.EqualTo(2));

            foreach (Task task in fromDb.Tasks)
            {
                Console.WriteLine("Task Id:{0}, Name:{1}".Frmt(task.Id, task.Name));
            }
        }

        [Test]
        public void t5_get_tasks_query()
        {
            PrepareData();
            //

            var fromDb = Session.Query<Task>()
                //.FetchMany(x => x.P)
                .Where(x => x.Project.Id > 0)
                .OrderBy(x => x.Id);

            Assert.That(fromDb, Is.Not.Null);
            Assert.That(fromDb.Count(), Is.EqualTo(4));

            foreach (Task task in fromDb)
            {
                Console.WriteLine("Task Id:{0}, Name:{1}".Frmt(task.Id, task.Name));
            }
        }


    }
}
