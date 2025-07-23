import { useForm } from "react-hook-form";
import { usersApi } from "../Services/ApiUsers";
import { StyledInput } from "./StyledInput"; // Make sure this supports `className` prop
import toast from "react-hot-toast";

const emailRules = {
  required: "Email is required.",
  maxLength: { value: 254, message: "Email must not exceed 254 characters." },
  pattern: {
    value: /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/,
    message: "Invalid email format.",
  },
};

const userNameRules = {
  required: "Username is required.",
  minLength: { value: 3, message: "Username must be at least 3 characters." },
  maxLength: {
    value: 50,
    message: "Username must not exceed 50 characters.",
  },
  pattern: {
    value: /^[a-zA-Z0-9_]{3,50}$/,
    message:
      "Username can contain letters, numbers, and underscores (3–50 characters).",
  },
};

type FormData = {
  email: string;
  userName: string;
};

export const UserForm = () => {
  const {
    register,
    handleSubmit,
    reset,
    formState: { errors, isSubmitting },
  } = useForm<FormData>();

  const onSubmit = async (data: FormData) => {
    try {
      await usersApi.addUser({
        email: data.email,
        userName: data.userName,
      });
      toast.success("User added successfully!");
      reset();
    } catch (err) {
      console.error("Add user failed:", err);
      toast.error("Failed to add user. Please try again.");
    }
  };

  return (
    <form
      onSubmit={handleSubmit(onSubmit)}
      className="w-full max-w-md bg-white shadow-md rounded-xl p-8 space-y-5"
    >
      <h2 className="text-2xl font-bold text-center text-gray-900">
        Add New User
      </h2>
      <p className="text-sm text-center text-gray-500">
        Please fill in the user details below
      </p>

      {/* Email */}
      <div>
        <label className="block text-sm font-medium text-gray-700 mb-1">
          Email
        </label>
        <StyledInput
          type="email"
          {...register("email", emailRules)}
          className="w-full px-4 py-2 border border-gray-300 rounded-md bg-blue-50 focus:outline-none focus:ring-2 focus:ring-blue-500"
          autoComplete="off"
        />
        {errors.email && (
          <p className="text-sm text-red-500 mt-1">{errors.email.message}</p>
        )}
      </div>

      {/* Username */}
      <div>
        <label className="block text-sm font-medium text-gray-700 mb-1">
          Username
        </label>
        <StyledInput
          type="text"
          {...register("userName", userNameRules)}
          className="w-full px-4 py-2 border border-gray-300 rounded-md bg-blue-50 focus:outline-none focus:ring-2 focus:ring-blue-500"
          autoComplete="off"
        />
        {errors.userName && (
          <p className="text-sm text-red-500 mt-1">{errors.userName.message}</p>
        )}
      </div>

      {/* Submit Button */}
      <button
        type="submit"
        disabled={isSubmitting}
        className="w-full bg-black text-white py-2 rounded-md hover:bg-gray-800 transition disabled:opacity-50 disabled:cursor-not-allowed"
      >
        {isSubmitting ? "Adding..." : "Add User"}
      </button>
    </form>
  );
};
