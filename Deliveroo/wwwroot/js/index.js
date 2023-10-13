$(document).ready(function () {

    function ViewModel() {
        var self = this;

        self.userName = ko.observable('@UserManager.GetUserName(User)');

        self.redirectToOriginalLink = function () {
            var originalLink = document.getElementById("manage");
            var originalHref = originalLink.getAttribute("href");
            window.location.href = originalHref;
        };
    }

    var viewModel = new ViewModel();
    ko.applyBindings(viewModel);

    

});