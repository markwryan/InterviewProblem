var mergeArray = require("../mergeArray");

describe("merge two length arrays together", function() {
    it("merges two equal length arrays", function() {
        const array1 = ["a","b","c"];
        const array2 = ["1","2","3"];
        const result = mergeArray.merge(array1, array2);

        expect(result).toEqual(["a","1","b","2","c","3"]);
    });

    it("merges two equal length arrays based on position", function() {
        const array1 = ["1","2","3"];
        const array2 = ["a","b","c"];
        const result = mergeArray.merge(array1, array2);

        expect(result).toEqual(["1","a","2","b","3","c"]);
    });

    it("merges two arrays of different lengths", function() {
        const array1 = ["a","b"];
        const array2 = ["1","2","3","4"];
        const result = mergeArray.merge(array1, array2);

       expect(result).toEqual(["a","1","b","2","3","4"]);
    });

    it("merges two larger equal length arrays", function() {
        const array1 = ["f", "5", "c", "q", "9", "-", "t", "1"];
        const array2 = ["4", "2", "3", "/", "e", "8", "v", "x"];
        const result = mergeArray.merge(array1, array2);

        expect(result).toEqual(["f", "4", "5", "2", "c", "3", "q", "/", "9", "e", "-", "8", "t", "v", "1", "x"]);
    });

    it("merges two larger arrays with different lengths", function() {
       const array1 = ["f", "5", "c", "q", "9", "-", "t", "1"];
       const array2 = ["4", "2", "3"];
       const result = mergeArray.merge(array1, array2);

       expect(result).toEqual(["f", "4", "5", "2", "c", "3", "q", "9", "-", "t", "1"]);
    });

    it("merges two items, where one is null", function() {
       const array1 = null;
       const array2 = ["4","2","3"];
       const result = mergeArray.merge(array1,array2);

       expect(result).toEqual(["4","2","3"]);
    });

    it("merges two items where both are null", function() {
        const array1 = null;
        const array2 = null;
        const result = mergeArray.merge(array1, array2);

        expect(result).toEqual(null);
    });

    it("merges two items where one is empty", function() {
        const array1 = ["4","3","2"];
        const array2 = [];
        const result = mergeArray.merge(array1, array2);

        expect(result).toEqual(["4","3","2"]);
    });

    it("merges two items where both are empty", function() {
        const array1 = [];
        const array2 = [];
        const result = mergeArray.merge(array1, array2);
        expect(result).toEqual([]);
    })
});