namespace UnitTestProject
{
    public class StudentConverterTest
    {
        [Fact]
        public void Should_Set_HonorRoll_When_Student_Grade_Above_90_And_Age_Above_21()
        {
            var students = new List<Student> { new Student { Name = "John", Age = 21, Grade = 95 } };
            var converter = new StudentConverter();

            var results = converter.ConvertStudents(students);

            Assert.True(results[0].HonorRoll);
        }

        [Fact]
        public void Should_Set_Exceptional_When_Student_Grade_Above_90_And_Age_Below_21()
        {
            var students = new List<Student> { new Student { Name = "John", Age = 20, Grade = 95 } };
            var converter = new StudentConverter();

            var results = converter.ConvertStudents(students);

            Assert.True(results[0].Exceptional);
        }

        [Fact]
        public void Should_Set_Passed_When_Student_Grade_Between_71_And_90()
        {
            var students = new List<Student> { new Student { Name = "John", Age = 20, Grade = 80 } };
            var converter = new StudentConverter();

            var results = converter.ConvertStudents(students);

            Assert.True(results[0].Passed);
        }

        [Fact]
        public void Should_Set_Passed_False_When_Student_Grade_Below_71()
        {
            var students = new List<Student> { new Student { Name = "John", Age = 20, Grade = 70 } };
            var converter = new StudentConverter();

            var results = converter.ConvertStudents(students);

            Assert.False(results[0].Passed);
        }

        [Fact]
        public void Should_Return_Empty_List_When_Given_Empty_List()
        {
            var students = new List<Student>();
            var converter = new StudentConverter();

            var results = converter.ConvertStudents(students);

            Assert.Empty(results);
        }

        [Fact]
        public void Should_Throw_ArgumentNullException_When_Given_Null()
        {
            List<Student> students = null;
            var converter = new StudentConverter();

            Assert.Throws<ArgumentNullException>(() => converter.ConvertStudents(students));
        }
    }
}