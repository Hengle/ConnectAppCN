using System;
using System.Collections.Generic;
using UnityEngine;

namespace ConnectApp.Utils {
    public static class JsonHelper {
        public static T[] FromJson<T>(string json) {
            Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.Items;
        }

        public static string ToJson<T>(T[] array) {
            Wrapper<T> wrapper = new Wrapper<T> {
                Items = array
            };
            return JsonUtility.ToJson(wrapper);
        }

        public static string ToJson<T>(List<T> list) {
            Wrapper<T> wrapper = new Wrapper<T> {
                Items = list.ToArray()
            };
            return JsonUtility.ToJson(wrapper);
        }

        public static string ToJson<T>(T[] array, bool prettyPrint) {
            Wrapper<T> wrapper = new Wrapper<T> {
                Items = array
            };
            return JsonUtility.ToJson(wrapper, prettyPrint);
        }

        [Serializable]
        class Wrapper<T> {
            public T[] Items;
        }
    }
}