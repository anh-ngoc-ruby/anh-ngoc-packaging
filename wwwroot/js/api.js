
    $(document).on("click", ".page-numbers, .previous, .next", function (e) {
        e.preventDefault();
        var page = $(this).data("page");
        var type = $(this).data("type");

        switch (type) {
            case "news":
                getListNews();
                break;
            case "product":
                getListProduct(page);
                break;
            default:
                console.warn("Type không hợp lệ:", type);
                return;
        }

    });

const getListProduct = (page = 1, pageSize = 10, search = "" ,categogySlug= "", sortBy="",SortType = "ASC" ) => {
    $.ajax({
        url: "/load-more/products",
        type: "GET",
        data: {
            page: page,
            pageSize: pageSize,
            "danh-muc": categogySlug,
            search,
            sortBy,
            SortType
        },
        success: function (result) {
            $(".tab-content").html(result);
            $(".page-numbers").removeClass("active");
            $(".page-numbers[data-page='" + page + "']").addClass("active");
            $("html, body").animate({ scrollTop: $(".shop-section").offset().top }, "fast");
        },
        error: function (xhr, status, error) {
            console.log("AJAX error: ", xhr.status, error);
        }
    });
}

const getListNews = (page = 1, pageSize = 10, search = "", sortBy = "", SortType = "ASC") => {
    $.ajax({
        url: "/load-more-news",
        type: "GET",
        data: {
            page: page,
            pageSize: pageSize,
            search,
            sortBy,
            SortType
        },
        success: function (result) {
            $(".tab-content").html(result);
            $(".page-numbers").removeClass("active");
            $(".page-numbers[data-page='" + page + "']").addClass("active");
            $("html, body").animate({ scrollTop: $(".shop-section").offset().top }, "fast");
        },
        error: function (xhr, status, error) {
            console.log("AJAX error: ", xhr.status, error);
        }
    });
}
$(document).on("click", ".product-category-btn", function () {
    var categorySlug = $(this).data("category");

    $(".product-category-btn").removeClass("active");
    $(this).addClass("active");

    var newUrl = new URL(window.location.href);

    newUrl.searchParams.set("danh-muc", categorySlug);

    var search = "";
    if (newUrl.searchParams.has("search")) {
        search = newUrl.searchParams.get("search");
    }

    window.history.pushState({}, "", newUrl);

    getListProduct(1, 10, search, categorySlug);
});


$(document).on("submit", ".search-toggle-box", function (e) {
    e.preventDefault();
    var searchText = $(".search-input").val().trim();
    var newUrl = new URL(window.location.href);

    // Clear the category parameter when searching
    newUrl.searchParams.delete("danh-muc");
    newUrl.searchParams.set("search", searchText);

    window.history.pushState({}, "", newUrl);

    // Remove active class from category buttons
    $(".product-category-btn").removeClass("active");

    // Call getListProduct with category parameter as empty string
    getListProduct(1, 10, searchText, "");
});

$(document).on("keypress", ".search-input", function (e) {
    if (e.which === 13) {
        e.preventDefault();
        var searchText = $(this).val().trim();
        var newUrl = new URL(window.location.href);

        // Clear the category parameter when searching
        newUrl.searchParams.delete("danh-muc");
        newUrl.searchParams.set("search", searchText);

        window.history.pushState({}, "", newUrl);

        // Remove active class from category buttons
        $(".product-category-btn").removeClass("active");

        // Call getListProduct with category parameter as empty string
        getListProduct(1, 10, searchText, "");
    }
});