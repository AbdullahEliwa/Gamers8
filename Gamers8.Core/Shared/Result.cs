using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Shared
{
    public class Result
    {
        internal Result(IEnumerable<string>? errors = null)
        {
            Errors = errors?.ToArray();
        }

        public bool Succeeded => Errors == default || !Errors.Any();

        public string[]? Errors { get; set; }


        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(errors);
        }
    }

    public class Result<T> : Result
    {
        public Result()
        {

        }

        internal Result(T data, IEnumerable<string> errors = null) : base(errors)
        {
            Data = data;
        }

        public T? Data { get; set; }


        public static Result<T> Failure(T data, IEnumerable<string> errors)
        {
            return new Result<T>(data, errors);
        }

        public new static Result<T> Failure(IEnumerable<string> errors)
        {
            return new Result<T>(default, errors);
        }

        public static Result<T> Success(T data)
        {
            return new Result<T>(data);
        }
    }

}
