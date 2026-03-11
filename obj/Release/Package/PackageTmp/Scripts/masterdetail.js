$(document).on("click", ".loadCourses", function () {
    let id = $(this).data("id");
    $("#enrollmentArea").empty();

    $.get("/MasterDetail/LoadCourses", { departmentId: id }, function (res) {
        $("#coursesArea").html(res);
    });
});

$(document).on("click", ".loadEnrollments", function () {
    let id = $(this).data("id");

    $.get("/MasterDetail/LoadEnrollments", { courseId: id }, function (res) {
        $("#enrollmentArea").html(res);
    });
});

$(document).on("click", ".editCourse", function () {
    let id = $(this).data("id");

    $.get("/Courses/Edit", { id: id }, function (res) {
        $("#courseModalContainer").html(res);
        $("#courseModal").modal("show");
    });
});


$(document).on("submit", "#courseForm", function (e) {
    e.preventDefault();
    let form = $(this);

    $.post("/Courses/Edit", form.serialize(), function (res) {
        $("#courseModal").modal("hide");
        $(".loadCourses[data-id=" + res.departmentId + "]").click();
    });
});


document.addEventListener("click", (e) => {
    if (e.target.classList.contains("loadCourses")) {
        const id = e.target.dataset.id;

        fetch(`/MasterDetail/LoadCourses?departmentId=${id}`)
            .then(res => res.text())
            .then(html => {
                document.getElementById("coursesArea").innerHTML = html;
                document.getElementById("enrollmentArea").innerHTML = "";
            });
    }
});

