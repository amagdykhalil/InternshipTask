import type { ReactNode } from "react";
import { Toaster } from "react-hot-toast";

export const Layout = ({ children }: { children: ReactNode }) => {
  return (
    <div className="w-screen h-screen flex items-center justify-center bg-gray-50">
      <Toaster />
      {children}
    </div>
  );
};
