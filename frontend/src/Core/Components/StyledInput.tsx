import React from "react";

export const StyledInput = (
  props: React.InputHTMLAttributes<HTMLInputElement>
) => (
  <input
    {...props}
    className={`w-full px-4 py-2 mb-3 border border-gray-300 rounded-md text-base text-black
                bg-blue-50 focus:outline-none focus:ring-2 focus:ring-blue-500 
                ${props.className ?? ""}`}
  />
);
