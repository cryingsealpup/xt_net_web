"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.Service = void 0;

function _typeof(obj) { if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var Service =
/*#__PURE__*/
function () {
  function Service() {
    _classCallCheck(this, Service);

    this.data = new Array();
    this.id = 0;
  }

  _createClass(Service, [{
    key: "add",
    value: function add(obj) {
      if (obj != null && _typeof(obj) == "object") {
        this.id++;
        obj.id = this.id;
        this.data.push(obj);
      }
    }
  }, {
    key: "getById",
    value: function getById(id) {
      for (var i = 0; i < this.data.length; i++) {
        if (this.data[i].id == id && id != null && typeof id == "string") return this.data[i];
      }

      return null;
    }
  }, {
    key: "getAll",
    value: function getAll() {
      return this.data;
    }
  }, {
    key: "deleteById",
    value: function deleteById(id) {
      for (var i = 0; i < this.data.length; i++) {
        if (id != null && this.data[i].id == id) {
          this.data.splice(i, 1);
          return this.data[i];
        }
      }

      return null;
    }
  }, {
    key: "replaceById",
    value: function replaceById(id, obj) {
      if (id != null && obj != null) {
        for (var i = 0; i < this.data.length; i++) {
          if (this.data[i].id == id) {
            obj.id = id.toString();
            this.data[i] = obj;
          }
        }
      }
    }
  }, {
    key: "updateById",
    value: function updateById(id, obj) {
      if (id != null && obj != null) {
        for (var i = 0; i < this.data.length; i++) {
          if (this.data[i].id == id) {
            for (var prop in obj) {
              this.data[i][prop] = obj[prop];
            }
          }
        }
      }
    }
  }]);

  return Service;
}();

exports.Service = Service;
;