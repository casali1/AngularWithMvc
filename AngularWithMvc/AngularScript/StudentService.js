app.service("StudentService", function ($http) {

	//get All Eployee
	this.getAllStudents = function () {
		return $http.get("Student/GetStudentList");
	};

	// Adding Record
	this.AddNewStudent = function (Student) {
		return $http({
			method: "post",
			url: "Student/AddStudent",
			data: JSON.stringify(Student),
			dataType: "json"
		});
	}

	// Updating record
	this.UpdateStudent = function (Student) {
		return $http({
			method: "post",
			url: "Student/UpdateStudent",
			data: JSON.stringify(Student),
			dataType: "json"
		});
	}

	// Deleting records
	this.deleteStudent = function (Id) {
		return $http.post('Student/DeleteStudent/' + Id)
	}
});
