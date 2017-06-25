
function CodeExample(id, title, description, url, imageUrl) {
    var self = this;
    self.Id = id;
    self.Title = title;
    self.Description = description;
    self.Url = url;
    self.ImageUrl = imageUrl;
}


// Overall viewmodel
function CodeExamplesViewModel() {

    var self = this;

    self.newExampleTitle = ko.observable();
    self.newExampleDescription = ko.observable();
    self.newExampleUrl = ko.observable();
    self.newExampleImageUrl = ko.observable();

    self.codeExamples = ko.observableArray([]);

    self.alertMessage = ko.observable("");
    self.alertMessageType = ko.observable();
       
    $.getJSON("/api/CodeExamples/GetAll/", function (allData) {
        console.log(allData);
        var mappedExamples = $.map(allData, function (item) { return new CodeExample(item.id, item.title, item.description, item.url, item.imageUrl) });
        console.log(mappedExamples);
        self.codeExamples(mappedExamples);
        console.log(self.codeExamples());
    });

    self.filenameList = ko.observableArray([]);

    $.getJSON("/api/CodeExamples/GetFilenames/", function (allData) {
        console.log(allData);
        for (i = 0; i < allData.length; i++) {
            filenameParts = allData[i].split('\\');
            self.filenameList.push("\\images\\" + filenameParts[filenameParts.length - 1]);
        }
    });

    //Operations
    this.photoUrl = ko.observable();
    self.photoResult;
    this.fileUpload = function (data, e) {
        var file = e.target.files[0];
        var reader = new FileReader();

        reader.onloadend = function (onloadend_e) {
            self.photoResult = reader.result; // Here is your base 64 encoded file. Do with it what you want.
            self.photoUrl(self.photoResult);
        };

        if (file) {
            reader.readAsDataURL(file);
        }
    };

    this.saveFile = function () {
        var data = new FormData();
        data.append(self.photoResult.name, self.photoResult.file);
        //Use ajax to send this file to the server
        $.ajax("/api/CodeExamples/SaveFile", {
            data: data,
            type: "post", contentType: "application/json",
            success: function (result) {
                self.alertMessage("Image saved to server...");
                $(alertMessageBar).fadeIn(500);
                $(alertMessageBar).fadeOut(5000);
                //Clear the file selector
                this.photoUrl('');
            }
        });
        
    };



    self.addCodeExample = function () {
        var newId = self.codeExamples().length + 1;
        console.log(newId);
        console.log(self.newExampleTitle());
        var newExampleItem = new CodeExample(newId, self.newExampleTitle(), self.newExampleDescription(), self.newExampleUrl(), self.newExampleImageUrl());
        console.log(newExampleItem);
        console.log(ko.toJSON(newExampleItem));

        $.ajax("/api/CodeExamples/Create", {
            data: ko.toJSON( newExampleItem ),
            type: "post", contentType: "application/json",
            success: function (result) {
                self.alertMessage("Code Example saved to database...");
                $(alertMessageBar).fadeIn(500);
                $(alertMessageBar).fadeOut(5000);
                newExampleItem.Id = result.id;
                self.codeExamples.push(newExampleItem);
            }
        });
        
        self.newExampleTitle("");
        self.newExampleDescription("");
        self.newExampleUrl("");
        self.newExampleImageUrl("");

    };

    self.removeCodeExample = function (example) {
        $.ajax("/api/CodeExamples/Delete/"+example.Id, {
            data: ko.toJSON(example.Id),
            type: "delete", contentType: "application/json",
            success: function (result) {
                self.alertMessage("Code Example removed from database...");
                $(alertMessageBar).fadeIn(500);
                $(alertMessageBar).fadeOut(5000);
                self.codeExamples.remove(example);
            }
        });

    };

    self.updateCodeExample = function (example) {
        console.log(example);

        $.ajax("/api/CodeExamples/Update/"+example.Id, {
            data: ko.toJSON(example),
            type: "put", contentType: "application/json",
            success: function (result) {
                self.alertMessage("Code Example updated in database...");
                $(alertMessageBar).fadeIn(500);
                $(alertMessageBar).fadeOut(5000);
            }
        });
     

    };

    self.saveAll = function () {
        console.log(self.codeExamples());
        console.log(ko.toJSON({ codeExamples: self.codeExamples }));

        $.ajax("/api/CodeExamples", {
            data: ko.toJSON({ codeExamples: self.codeExamples }),
            type: "post", contentType: "application/json",
            success: function (result) { alert(result) }
        });

    };

}

ko.applyBindings(new CodeExamplesViewModel());
